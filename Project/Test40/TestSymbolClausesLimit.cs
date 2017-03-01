using System.Data;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using LambdicSql;
using LambdicSql.feat.Dapper;
using static LambdicSql.Oracle.Symbol;
using static Test.Helper.DBProviderInfo;
using Test.Helper;

namespace Test
{
    [TestClass]
    public class TestSymbolClausesLimit
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
        public void Test_RowNum()
        {
            var sql = Db<DB>.Sql(db =>
                 Select(Asterisk(db.tbl_remuneration)).
                 From(db.tbl_remuneration).
                 Where(Between(RowNum(), 1, 3)).
                 OrderBy(Asc(db.tbl_remuneration.id))
                 );

            var datas = _connection.Query(sql).ToList();
            Assert.AreEqual(3, datas.Count);
            AssertEx.AreEqual(sql, _connection,
 @"SELECT *
FROM tbl_remuneration
WHERE ROWNUM BETWEEN :p_0 AND :p_1
ORDER BY
	tbl_remuneration.id ASC",
1, 3);
        }
    }
}
