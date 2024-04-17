//16. Menghitung estimasi biaya suatu perjalanan
using System;

public class HitungBiayaPerjalanan{
    public static void Main(string[] args){
        Console.WriteLine("===MENGHITUNG ESTIMASI BIAYA PERJALANAN===");
        Console.WriteLine("Jenis Kendaran:");
        Console.WriteLine("1. Roda Dua");
        Console.WriteLine("2. Roda Empat");
        Console.WriteLine("3. Roda lebih dari Empat");

        Console.Write("Masukkan jenis kendaraan (1/2/3): ");
        int jenisKendaraan = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Jenis Bahan Bakar:");
        Console.WriteLine("1. Solar");
        Console.WriteLine("2. Pertalite");
        Console.WriteLine("3. Pertamax");
        
        Console.Write("Masukkan jenis bahan bakar (pilih 1/2/3): ");
        int jenisBBM = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("Masukkan jarak tempuh perjalanan (KM): ");
        double jarak = Convert.ToDouble(Console.ReadLine());

        double konsumsiBBM = 0;
        switch (jenisKendaraan){
            case 1://Roda dua
            konsumsiBBM = 26; //diasumsikan 26 km/liter
            break;
            
            case 2:// roda empat
            konsumsiBBM = 13; // diasumsikan 13 km/liter
            break;
            
            case 3:// roda lebih ari empat
            konsumsiBBM = 8; //diasumsikan 8 km/liter
            break;
            
            default:
            Console.WriteLine ("Jenis Kendaraan tidak valid! silahkan pilih 1/2/3");
            return;
        }
        
        double hargaBBM = 0;
        switch (jenisBBM){
            case 1://solar
            hargaBBM = 6800;
            break;
            
            case 2: //pertalite
            hargaBBM = 10000;
            break;
            
            case 3: //pertamax
            hargaBBM = 12950;
            break;
            
            default:
            Console.WriteLine("Jenis BBM tidak valid! silahkan pilih 1/2/3");
            return;
        }
        
        double totalBiaya = (jarak / konsumsiBBM) * hargaBBM;
        
        Console.WriteLine ($"Total estimasi biaya adalah Rp{totalBiaya:N2}");
    }
}