namespace lesson3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //char tipi simvol tipidir
            //deyisenin qarsinda var yazildiqda emeliyyatin neticesinin tipini avtomatik verir
            // var verilmedikde ise deyisenin tipi mutleq qeyd edilmedir! 

            char var1 = 'D';
            char var2 = 'I';
            char var3 = 'N';
            var result = var1 + var2 + var3;
            //string result=var1.ToString()+ var2.ToString()+ var3.ToString ();
            Console.WriteLine(result);

            string text = "AZERBAYCAN  QEHREMANLAR OLKESIDIR";
            text.Trim(); //soldan ve sagdan bosluqlari silir
            Console.WriteLine(text);
            string new_text=text.Replace("QEHREMANLAR", "MUBARIZLER"); //replace funksiyasi text daxilinde  soz ve ya herfi basqasi ile evez edir
            Console.WriteLine(new_text);
        }
    }
}