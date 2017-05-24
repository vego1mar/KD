using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace RLECoding
{
    struct PpmRgbPixel
    {
        public ushort Red { get; set; }
        public ushort Green { get; set; }
        public ushort Blue { get; set; }
    }

    class PpmFileData
    {
        public string Marker { get; set; }
        public ulong Width { get; set; }
        public ulong Heigth { get; set; }
        public ushort MaxValue { get; set; }
        public List<PpmRgbPixel> Pixels { get; set; }
    }

    class PpmFile
    {

        public string FilePath { get; set; }
        public long FileSizeInBytes { get; private set; }
        public Encoding Encoding { get; set; }
        public Exception LastException { get; private set; }
        public PpmFileData Data { get; private set; }
        public List<string> SourceLineByLine { get; private set; }

        public PpmFile()
        {
            FilePath = "";
            FileSizeInBytes = 0;
            Encoding = Encoding.UTF8;
            LastException = null;
            Data = new PpmFileData();
            Data.Pixels = new List<PpmRgbPixel>();
            SourceLineByLine = null;
        }

        private bool IsFilePathValid()
        {
            FileSizeInBytes = 0;
            bool isPossiblePath = false;
            FileInfo info = new FileInfo( FilePath );
            FileSizeInBytes = info.Length;
            isPossiblePath = FilePath.IndexOfAny( Path.GetInvalidPathChars() ) == -1;

            if ( File.Exists( FilePath ) && isPossiblePath ) {
                return true;
            }

            return false;
        }

        public bool Read()
        {
            try {
                if ( !IsFilePathValid() ) {
                    LastException = new ArgumentException( "The provided file path is not valid." );
                    return false;
                }

                SourceLineByLine = new List<string>();

                using ( StreamReader reader = new StreamReader( FilePath, Encoding ) ) {
                    while ( !reader.EndOfStream ) {
                        SourceLineByLine.Add( reader.ReadLine() );
                    }
                }
            }
            catch ( ArgumentNullException x ) {
                LastException = x;
                return false;
            }
            catch ( ArgumentException x ) {
                LastException = x;
                return false;
            }
            catch ( System.Security.SecurityException x ) {
                LastException = x;
                return false;
            }
            catch ( FileNotFoundException x ) {
                LastException = x;
                return false;
            }
            catch ( PathTooLongException x ) {
                LastException = x;
                return false;
            }
            catch ( ObjectDisposedException x ) {
                LastException = x;
                return false;
            }
            catch ( DirectoryNotFoundException x ) {
                LastException = x;
                return false;
            }
            catch ( UnauthorizedAccessException x ) {
                LastException = x;
                return false;
            }
            catch ( NotSupportedException x ) {
                LastException = x;
                return false;
            }
            catch ( OutOfMemoryException x ) {
                LastException = x;
                return false;
            }
            catch ( IOException x ) {
                LastException = x;
                return false;
            }
            catch ( Exception x ) {
                LastException = x;
                return false;
            }

            return true;
        }

        public bool Parse()
        {
            try {
                int successor = 0;
                successor = GetMarker( ref successor );
                successor = GetWidthAndHeight( ref successor );
                successor = GetMaximumPixelValue( ref successor );
                successor = GetPixels( ref successor );
            }
            catch ( ArgumentOutOfRangeException x ) {
                LastException = x;
                return false;
            }
            catch ( ArgumentNullException x ) {
                LastException = x;
                return false;
            }
            catch ( InvalidCastException x ) {
                LastException = x;
                return false;
            }
            catch ( OverflowException x ) {
                LastException = x;
                return false;
            }
            catch ( FormatException x ) {
                LastException = x;
                return false;
            }
            catch ( Exception x ) {
                LastException = x;
                return false;
            }

            return true;
        }

        private int GetMarker( ref int startIndex )
        {
            for ( int j = startIndex; j < SourceLineByLine.Count; j++ ) {
                if ( SourceLineByLine[j].IndexOf( '#' ) == -1 ) {
                    Data.Marker = SourceLineByLine[j];
                    return j;
                }

                startIndex = j;
            }

            return -1;
        }

        private int GetWidthAndHeight( ref int startIndex )
        {
            for ( int j = startIndex + 1; j < SourceLineByLine.Count; j++ ) {
                if ( SourceLineByLine[j].IndexOf( '#' ) == -1 ) {
                    List<ulong> lineList = SplitIntoSeparatedData<ulong>( SourceLineByLine[j] );
                    Data.Width = lineList[0];
                    Data.Heigth = lineList[1];
                    return j;
                }

                startIndex = j;
            }

            return -1;
        }

        private int GetMaximumPixelValue( ref int startIndex )
        {
            for ( int j = startIndex + 1; j < SourceLineByLine.Count; j++ ) {
                if ( SourceLineByLine[j].IndexOf( '#' ) == -1 ) {
                    List<ushort> lineList = SplitIntoSeparatedData<ushort>( SourceLineByLine[j] );
                    Data.MaxValue = lineList[0];
                    return j;
                }

                startIndex = j;
            }

            return -1;
        }

        private int GetPixels( ref int startIndex )
        {
            Data.Pixels = new List<PpmRgbPixel>();
            int j = 0;

            for ( j = startIndex + 1; j < SourceLineByLine.Count; j++ ) {
                if ( SourceLineByLine[j].IndexOf( '#' ) == -1 ) {
                    List<ushort> lineList = SplitIntoSeparatedData<ushort>( SourceLineByLine[j] );
                    GetPixelsTrios( lineList );
                }

                startIndex = j;
            }

            return j;
        }

        private List<T> SplitIntoSeparatedData<T>( string dataTypesToParse )
        {
            List<T> dataList = new List<T>();
            int conditionRhs = dataTypesToParse.Length - 1;
            StringBuilder builder = new StringBuilder();

            for ( int i = 0; i < conditionRhs; i++ ) {
                builder.Clear();
                builder.Append( dataTypesToParse[i] );

                while ( !Char.IsWhiteSpace( dataTypesToParse[i] ) && i < conditionRhs ) {
                    i++;
                    builder.Append( dataTypesToParse[i] );
                }

                dataList.Add( GetConvertedValue<T>( builder.ToString() ) );
            }

            return dataList;
        }

        private T GetConvertedValue<T>( string value )
        {
            return (T) Convert.ChangeType( value, typeof( T ) );
        }

        private void GetPixelsTrios( List<ushort> valuesFromLine )
        {
            for ( int i = 0; i <= valuesFromLine.Count - 3; i = i + 3 ) {
                Data.Pixels.Add( new PpmRgbPixel() {
                    Red = valuesFromLine[i],
                    Green = valuesFromLine[i + 1],
                    Blue = valuesFromLine[i + 2]
                } );
            }
        }

        public List<ushort> GetPixelsDataAsList()
        {
            List<ushort> values = new List<ushort>() {
                Capacity = Data.Pixels.Count * 3
            };

            foreach ( var pixel in Data.Pixels ) {
                values.Add( pixel.Red );
                values.Add( pixel.Green );
                values.Add( pixel.Blue );
            }

            values.TrimExcess();
            return values;
        }

    }
}
