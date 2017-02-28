using System.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.Oracle.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;
using LambdicSql.Oracle;

namespace Test
{
    [TestClass]
    public class TestDataType
    {
        public TestContext TestContext { get; set; }
        public IDbConnection _connection;

        [TestInitialize]
        public void TestInitialize()
        {
            _connection = TestEnvironment.CreateConnection(TestContext);
            _connection.Open();
        }

        [TestCleanup]
        public void TestCleanup() => _connection.Dispose();

        [TestMethod]
        public void Test_CreateTable_Oracle()
        {
            if (!_connection.IsTarget(TargetDB.Oracle)) return;

            CleanUpCreateDropTestTable();

            var sql = Db<DBForCreateTest>.Sql(db =>
                CreateTable(db.table3,
                    new Column(db.table3.obj1, DataType.VarChar2(1)),
                    new Column(db.table3.obj2, DataType.NVarChar2(1)),
                    new Column(db.table3.obj3, DataType.Char(1)),
                    new Column(db.table3.obj4, DataType.NChar(1)),
                    new Column(db.table3.obj5, DataType.Number(1, 2)),
                    new Column(db.table3.obj6, DataType.Binary_Float()),
                    new Column(db.table3.obj7, DataType.Binary_Double()),
                    new Column(db.table3.obj8, DataType.Date()),
                    new Column(db.table3.obj9, DataType.TimeStamp(1)),
                 // new Column(db.table3.obj10, DataType.Raw()),
                 // new Column(db.table3.obj11, DataType.LongRaw()),
                    new Column(db.table3.obj12, DataType.BFile()),
                    new Column(db.table3.obj13, DataType.Blob()),
                    new Column(db.table3.obj14, DataType.Long()),
                    new Column(db.table3.obj15, DataType.Clob()),
                    new Column(db.table3.obj16, DataType.NClob()),
                    new Column(db.table3.obj17, DataType.XmlType()),
                    new Column(db.table3.obj18, DataType.TimeStampWithTimeZone()),
                    new Column(db.table3.obj19, DataType.TimeStampWithTimeZone(1))
                ));

            _connection.Execute(sql);
        }

        void CleanUpCreateDropTestTable()
        {
            try
            {
                var sql = Db<DBForCreateTest>.Sql(db => DropTable(db.table3));
                _connection.Execute(sql);
            }
            catch { }
        }
    }
}
