using e = Basic.Data.Entities;
using m = Basic.WebAPI.Models;

namespace Basic.Logic.Mappers
{
    public static class TestTableMapper
    {
        public static m.TestTable ToModel(this e.TestTable entity)
        {
            return new m.TestTable
            {
                Id = entity.Id,
                test_bigint = entity.test_bigint,
                //test_binary = entity.test_binary,
                test_bit = entity.test_bit,
                test_char = entity.test_char,
                test_date = entity.test_date,
                test_datetime = entity.test_datetime,
                test_datetime2 = entity.test_datetime2,
                test_decimal = entity.test_decimal,
                test_float = entity.test_float,
                //test_image = entity.test_image,
                test_int = entity.test_int,
                test_money = entity.test_money,
                test_nchar = entity.test_nchar,
                test_ntext = entity.test_ntext,
                test_numeric = entity.test_numeric,
                test_nvarchar = entity.test_nvarchar,
                //test_real = entity.test_real,
                test_smalldatetime = entity.test_smalldatetime,
                //test_smallint = entity.test_smallint,
                //test_smallmoney = entity.test_smallmoney,
                test_text = entity.test_text,
                test_time = entity.test_time,
                test_timestamp = entity.test_timestamp,
                //test_tinyint = entity.test_tinyint,
                test_uniqueidentifier = entity.test_uniqueidentifier,
                //test_varbinary = entity.test_varbinary,
                test_varchar = entity.test_varchar,
                test_xml = entity.test_xml,
            };
        }

        public static e.TestTable ToDataModel(this m.TestTable model)
        {
            return new e.TestTable
            {
                Id = model.Id,
                test_bigint = model.test_bigint,
                //test_binary = entity.test_binary,
                test_bit = model.test_bit,
                test_char = model.test_char,
                test_date = model.test_date,
                test_datetime = model.test_datetime,
                test_datetime2 = model.test_datetime2,
                test_decimal = model.test_decimal,
                test_float = model.test_float,
                //test_image = entity.test_image,
                test_int = model.test_int,
                test_money = model.test_money,
                test_nchar = model.test_nchar,
                test_ntext = model.test_ntext,
                test_numeric = model.test_numeric,
                test_nvarchar = model.test_nvarchar,
                //test_real = entity.test_real,
                test_smalldatetime = model.test_smalldatetime,
                //test_smallint = entity.test_smallint,
                //test_smallmoney = entity.test_smallmoney,
                test_text = model.test_text,
                test_time = model.test_time,
                test_timestamp = model.test_timestamp,
                //test_tinyint = entity.test_tinyint,
                test_uniqueidentifier = model.test_uniqueidentifier,
                //test_varbinary = entity.test_varbinary,
                test_varchar = model.test_varchar,
                test_xml = model.test_xml,
            };
        }

    }
}