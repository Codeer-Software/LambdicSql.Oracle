using LambdicSql.ConverterServices;
using LambdicSql.ConverterServices.SymbolConverters;

namespace LambdicSql.Oracle
{
    /// <summary>
    /// Data type.
    /// It can only be used within methods of the LambdicSql.Db class.
    /// </summary>
    public static class DataType
    {
        /// <summary>
        /// BFILE
        /// </summary>
        /// <returns>BFILE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement BFile() { throw new InvalitContextException(nameof(BFile)); }

        /// <summary>
        /// BINARY_DOUBLE
        /// </summary>
        /// <returns>BINARY_DOUBLE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Binary_Double() { throw new InvalitContextException(nameof(Binary_Double)); }

        /// <summary>
        /// BINARY_FLOAT
        /// </summary>
        /// <returns>BINARY_FLOAT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Binary_Float() { throw new InvalitContextException(nameof(Binary_Float)); }

        /// <summary>
        /// BLOB
        /// </summary>
        /// <returns>BLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Blob() { throw new InvalitContextException(nameof(Blob)); }
        
        /// <summary>
        /// CHAR
        /// </summary>
        /// <returns>CHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Char() { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>CHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement Char(int n) { throw new InvalitContextException(nameof(Char)); }

        /// <summary>
        /// CLOB
        /// </summary>
        /// <returns>CLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Clob() { throw new InvalitContextException(nameof(Clob)); }

        /// <summary>
        /// DATE
        /// </summary>
        /// <returns>DATE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Date() { throw new InvalitContextException(nameof(Date)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal() { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision) { throw new InvalitContextException(nameof(Decimal)); }


        /// <summary>
        /// DECIMAL
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>DECIMAL</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Decimal(int precision, int scale) { throw new InvalitContextException(nameof(Decimal)); }

        /// <summary>
        /// INT
        /// </summary>
        /// <returns>INT</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Int() { throw new InvalitContextException(nameof(Int)); }

        /// <summary>
        /// LONG
        /// </summary>
        /// <returns>LONG</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Long() { throw new InvalitContextException(nameof(Long)); }

        /// <summary>
        /// NCHAR
        /// </summary>
        /// <returns>NCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NChar() { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// NCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement NChar(int n) { throw new InvalitContextException(nameof(NChar)); }

        /// <summary>
        /// NCLOB
        /// </summary>
        /// <returns>NCLOB</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NClob() { throw new InvalitContextException(nameof(NClob)); }

        /// <summary>
        /// NUMBER
        /// </summary>
        /// <returns>NUMBER</returns>
        [ClauseStyleConverter]
        public static DataTypeElement Number() { throw new InvalitContextException(nameof(Number)); }

        /// <summary>
        /// NUMBER
        /// </summary>
        /// <param name="precision">precision</param>
        /// <returns>NUMBER</returns>
        [FuncStyleConverter]
        public static DataTypeElement Number(int precision) { throw new InvalitContextException(nameof(Number)); }

        /// <summary>
        /// NUMBER
        /// </summary>
        /// <param name="precision">precision</param>
        /// <param name="scale">scale</param>
        /// <returns>NUMBER</returns>
        [FuncStyleConverter]
        public static DataTypeElement Number(int precision, int scale) { throw new InvalitContextException(nameof(Number)); }

        /// <summary>
        /// NVARCHAR2
        /// </summary>
        /// <returns>NVARCHAR2</returns>
        [ClauseStyleConverter]
        public static DataTypeElement NVarChar2() { throw new InvalitContextException(nameof(NVarChar2)); }

        /// <summary>
        /// NVARCHAR2
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>NVARCHAR2</returns>
        [FuncStyleConverter]
        public static DataTypeElement NVarChar2(int n) { throw new InvalitContextException(nameof(NVarChar2)); }

        /// <summary>
        /// TIMESTAMP
        /// </summary>
        /// <returns>TIMESTAMP</returns>
        [ClauseStyleConverter]
        public static DataTypeElement TimeStamp() { throw new InvalitContextException(nameof(TimeStamp)); }

        /// <summary>
        /// TIMESTAMP
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIMESTAMP</returns>
        [FuncStyleConverter]
        public static DataTypeElement TimeStamp(int n) { throw new InvalitContextException(nameof(TimeStamp)); }

        /// <summary>
        /// TIME STAMP WITH TIME ZONE
        /// </summary>
        /// <returns>TIMESTAMP</returns>
        [ClauseStyleConverter(Name = "TIMESTAMP WITH TIME ZONE")]
        public static DataTypeElement TimeStampWithTimeZone() { throw new InvalitContextException(nameof(TimeStampWithTimeZone)); }

        /// <summary>
        /// TIME STAMP WITH TIME ZONE
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>TIMESTAMP</returns>
        [MethodFormatConverter(Format = "TIMESTAMP([0]) WITH TIME ZONE|")]
        public static DataTypeElement TimeStampWithTimeZone(int n) { throw new InvalitContextException(nameof(TimeStampWithTimeZone)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <returns>VARCHAR</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar() { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar(int n) { throw new InvalitContextException(nameof(VarChar)); }

        /// <summary>
        /// VARCHAR2
        /// </summary>
        /// <returns>VARCHAR2</returns>
        [ClauseStyleConverter]
        public static DataTypeElement VarChar2() { throw new InvalitContextException(nameof(VarChar2)); }

        /// <summary>
        /// VARCHAR2
        /// </summary>
        /// <param name="n">n</param>
        /// <returns>VARCHAR2</returns>
        [FuncStyleConverter]
        public static DataTypeElement VarChar2(int n) { throw new InvalitContextException(nameof(VarChar2)); }

        /// <summary>
        /// XMLTYPE
        /// </summary>
        /// <returns>XMLTYPE</returns>
        [ClauseStyleConverter]
        public static DataTypeElement XmlType() { throw new InvalitContextException(nameof(XmlType)); }
    }
}
