using System;

namespace Basic.WebAPI.Models
{
    public class TestTable
    {
        // todo sort objects
        public long Id { get; set; }
        public long test_bigint { get; set; }
        //public object test_binary { get; set; }
        public bool test_bit { get; set; }
        public char test_char { get; set; }
        public DateTime test_date { get; set; }
        public DateTime test_datetime { get; set; }
        public DateTime test_datetime2 { get; set; }
        public decimal test_decimal { get; set; }
        public float test_float { get; set; }
        //public object test_image { get; set; }
        public int test_int { get; set; }
        public decimal test_money { get; set; }
        public char test_nchar { get; set; }
        public string test_ntext { get; set; }
        public decimal test_numeric { get; set; }
        public string test_nvarchar { get; set; }
        //public object test_real { get; set; }
        public DateTime test_smalldatetime { get; set; }
        //public object test_smallint { get; set; }
        //public object test_smallmoney { get; set; }
        public string test_text { get; set; }
        public DateTime test_time { get; set; }
        public DateTime test_timestamp { get; set; }
        //public object test_tinyint { get; set; }
        public Guid test_uniqueidentifier { get; set; }
        //public object test_varbinary { get; set; }
        public string test_varchar { get; set; }
        public string test_xml { get; set; }
    }
}