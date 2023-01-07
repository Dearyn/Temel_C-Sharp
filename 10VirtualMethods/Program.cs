 namespace _10VirtualMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MysqlVeriTabani mysqlVeriTabani = new MysqlVeriTabani();
            mysqlVeriTabani.VeriTabaninaKaydet();
            mysqlVeriTabani.VeriTabanindanSil();

            SqlServerVeriTabani sqlServerVeriTabani = new SqlServerVeriTabani();
            sqlServerVeriTabani.VeriTabaninaKaydet();
            sqlServerVeriTabani.VeriTabanindanSil();

            Console.ReadLine();
        }
    }

    class VeriTabaniIslemleri
    {
        public virtual void VeriTabaninaKaydet()
        {
            Console.WriteLine("Default olarak ana veritabanına eklendi");
        }

        public virtual void VeriTabanindanSil()
        {
            Console.WriteLine("Default olarak ana veritabanından silindi");
        }
    }

    class MysqlVeriTabani : VeriTabaniIslemleri
    {
        public override void VeriTabaninaKaydet()
        {
            Console.WriteLine("MYSQL olarak ana veritabanına eklendi");
        }
    }

    class SqlServerVeriTabani : VeriTabaniIslemleri
    {
        public override void VeriTabaninaKaydet()
        {
            Console.WriteLine("SQL olarak ana veritabanından eklendi");
        }
    }
}