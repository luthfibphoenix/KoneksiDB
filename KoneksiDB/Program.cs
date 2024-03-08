using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace KoneksiDB
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string strKoneksi = "";
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Koneksi Menggunakan Windows Authentication");
                    Console.WriteLine("2. Koneksi Menggunakan SQL Server Authentication");
                    Console.WriteLine("3. EXIT");
                    Console.WriteLine("\nEnter your choice (1-3): ");
                    char ch = Convert.ToChar(Console.ReadLine());

                    switch (ch)
                    {
                        case '1':
                            {
                                try
                                {
                                    strKoneksi = "Data Source = LUTHFI\\LUTHFI; " +
                                        "Initial Catalog = IceNTea;Integrated Security = True;";
                                    SqlConnection koneksi = new SqlConnection();
                                    koneksi.ConnectionString = strKoneksi;
                                    koneksi.Open();
                                    if (koneksi.State == System.Data.ConnectionState.Open)
                                    {
                                        koneksi.Close();
                                    }
                                    Console.WriteLine("Koneksi Berhasil");
                                    Console.ReadLine();
                                }
                                catch (Exception ex)
                                {
                                    Console.WriteLine("Periksa Kembali Server Anda!\n" + ex.Message);
                                    Console.ReadLine();

                                }
                            }
                            break;
                        case '2':
                            {
                                try
                                {
                                    strKoneksi = "Data Source = LUTHFI\\LUTHFI; " +
                                        "Initial Catalog = IceNTea;User ID = sa; Password = 321;";
                                    SqlConnection koneksi = new SqlConnection();
                                    koneksi.ConnectionString = strKoneksi;
                                    koneksi.Open();
                                    if (koneksi.State == System.Data.ConnectionState.Open)
                                    {
                                        koneksi.Close();
                                    }
                                    Console.WriteLine("Koneksi Berhasil");
                                    Console.ReadLine();
                                }
                                catch(Exception ex)
                                {
                                    Console.WriteLine("Periksa Kembali Server Anda!\n" + ex.Message);
                                    Console.ReadLine();

                                }
                            }
                            break;
                        case '3':
                            return;
                        default:
                            {
                                Console.WriteLine("\nOpsi tidak valid");
                                break;
                            }
                    }
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.WriteLine("\nPeriksa angka yang anda masukkan.\n" + e.Message.ToString());
                }
            }
        }
    }
}
