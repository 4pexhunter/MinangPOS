// list barange
int Rendang = 35000;
int AyamPop = 28000;
int DendengBalado = 38000;
int GulaiTunjang = 40000;
int GulaiAyam = 30000;
int GulaiIkan = 32000;
int SambalIjo = 5000;
int TelurBalado = 10000;
int Perkedel = 7000;
int NasiPutih = 8000;

Console.WriteLine("==== Kasir Apex V0.0.1 ====");
Console.WriteLine("    RM Minang Bpk Samsul   ");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("Daftar Barang : ");
Console.WriteLine("1. Rendang - Rp 35.000");
Console.WriteLine("2. Ayam Pop - Rp 28.000");
Console.WriteLine("3. Dendeng Balado - Rp 38.000");
Console.WriteLine("4. Gulai Tunjang - Rp 40.000");
Console.WriteLine("5. Gulai Ayam - Rp 30.000");
Console.WriteLine("6. Gulai Ikan - Rp 32.000");
Console.WriteLine("7. Sambal Ijo - Rp 5.000");
Console.WriteLine("8. Telur Balado - Rp 10.000");
Console.WriteLine("9. Perkedel - Rp 7.000");
Console.WriteLine("10. Nasi Putih - Rp 8.000");
Console.WriteLine();
Console.WriteLine();

// input pembeli
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.Write("Nama Pembeli : ");
string namaPembeli = Console.ReadLine();
Console.WriteLine("Barang yang dibeli :   ");
Console.WriteLine();
string barang = Console.ReadLine();
Console.WriteLine("Jumlah Barang : ");
int jumlah = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("----------------------------");

//input dan ngitung harga

int totalHarga = 0;

if (barang == "Rendang")
{
    totalHarga = Rendang * jumlah;
}
else if (barang == "Ayam Pop")
{
    totalHarga = AyamPop * jumlah;
}
else if (barang == "Dendeng Balado")
{
    totalHarga = DendengBalado * jumlah;
}  
else if (barang == "Gulai Tunjang")
{
    totalHarga = GulaiTunjang * jumlah;
}
else if (barang == "Gulai Ayam")
{
    totalHarga = GulaiAyam * jumlah;
}
else if (barang == "Gulai Ikan")
{
    totalHarga = GulaiIkan * jumlah;
}
else if (barang == "Sambal Ijo")
{
    totalHarga = SambalIjo * jumlah;
}
else if (barang == "Telur Balado")
{
    totalHarga = TelurBalado * jumlah;
}
else if (barang == "Perkedel")
{
    totalHarga = Perkedel * jumlah;
}
else if (barang == "Nasi Putih")
{
    totalHarga = NasiPutih * jumlah;
}
else
{
    Console.WriteLine("Makanan Sold Out.");
}
const double PAJAK = 0.10;
Console.WriteLine("Harga"+ " : " + totalHarga * PAJAK);
Console.WriteLine("Masukkan jumlah uang yang dibayarkan : ");
int uangDibayarkan = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Total Harga : " + totalHarga );
Console.WriteLine("Pajak 10% : " + (totalHarga * PAJAK));
Console.WriteLine("Uang Dibayarkan : " + uangDibayarkan);
Console.WriteLine("Kembalian : " + (uangDibayarkan - totalHarga - (totalHarga * PAJAK)));
//struk pembelian
Console.WriteLine("----------------------------");
Console.WriteLine("-   RM Minang Bpk Samsul   -");
Console.WriteLine("----------------------------");
Console.WriteLine();
Console.WriteLine("Pembeli : " + namaPembeli    );
Console.WriteLine();
Console.WriteLine("Makanan : " + barang         );
Console.WriteLine();  
Console.WriteLine("Jumlah  : " + jumlah         );
Console.WriteLine();
Console.WriteLine("Total   : " + (totalHarga + (totalHarga * PAJAK))     );
Console.WriteLine("Pajak 10% : " + (totalHarga * PAJAK));
Console.WriteLine();
Console.WriteLine("----------------------------");
Console.WriteLine("-   Maacih Nyaaaaaak!!!!   -");
Console.WriteLine("----------------------------");

