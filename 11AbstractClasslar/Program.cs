namespace _11AbstractClasslar
{
    internal class Program
    {
        abstract class VeriTabani
        {
            public void Ekle()
            {
                Console.WriteLine("Ekleme Yapıldı");
            }

            public abstract void Silme();
        }

        class SqlVeriTabani : VeriTabani
        {
            public override void Silme()
            {
                throw new NotImplementedException();
            }
        }

        class OracleVeriTabani : VeriTabani
        {
            public override void Silme()
            {
                Console.WriteLine("Oracle Silindi Yapıldı");
            }
        }


        static void Main(string[] args)
        {
            VeriTabani veriTabani1 = new SqlVeriTabani();
            veriTabani1.Ekle();
            veriTabani1.Silme();

            VeriTabani veriTabani2 = new OracleVeriTabani();
            veriTabani2.Ekle();
            veriTabani2.Silme();

            Console.ReadLine();
        }
    }
}