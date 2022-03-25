using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Exercise2PABD
{
    
    class Program
    {
        
        public void InsertData()
        {
            SqlConnection con = null;
            try
            {
                con = new SqlConnection("data source =DESKTOP-SVN0V6C;database=Tugas2_20200140030_B;Integrated Security = TRUE");
                con.Open();

                SqlCommand cm = new SqlCommand
                        ("insert into Apotek (Id_Apotek, Nama, Alamat, Telepon, Id_Pegawai) values ('4444444441', 'Apotek Jaya', 'Bantul', '087838836874', '7371121352')" 
                        + ("insert into Apotek (Id_Apotek, Nama, Alamat, Telepon, Id_Pegawai) values ('4444444442', 'Kimia Farma', 'Bantul', '087838866874', '7371121302')")
                        + ("insert into Apotek (Id_Apotek, Nama, Alamat, Telepon, Id_Pegawai) values ('4444444443', 'K24', 'Sentul', '087838866874', '7371141302')")
                        + ("insert into Apotek (Id_Apotek, Nama, Alamat, Telepon, Id_Pegawai) values ('4444444444', 'Apotek Bagas', 'Kaliurang', '087838866854', '7371121302')")
                        + ("insert into Apotek (Id_Apotek, Nama, Alamat, Telepon, Id_Pegawai) values ('4444444445', 'Apotek Sukamampu', 'Manggala', '087838866774', '7371121302')")
                        + ("insert into Obat (Kode_Obat, Nama, Harga_Beli, Harga_Jual, Stok) values ('5555555551','Teramadol','Rp5000','Rp7000','1000')")
                        + ("insert into Obat (Kode_Obat, Nama, Harga_Beli, Harga_Jual, Stok) values ('5555555552','Paracetamol','Rp3000','Rp5000','1000')")
                        + ("insert into Obat (Kode_Obat, Nama, Harga_Beli, Harga_Jual, Stok) values ('5555555553','Bodrex','Rp5000','Rp8000','1000')")
                        + ("insert into Obat (Kode_Obat, Nama, Harga_Beli, Harga_Jual, Stok) values ('5555555554','Bodrex Flu','Rp6000','Rp9000','1000')")
                        + ("insert into Obat (Kode_Obat, Nama, Harga_Beli, Harga_Jual, Stok) values ('5555555555','Bodrex Flu dan Batuk','Rp6000','Rp9000','1000')")
                        + ("insert into Pegawai (Id_Pegawai, Nama, Jenis_Kelamin, Id_Buku) values ('6666666661','Jaya','P','0000000001')")
                        + ("insert into Pegawai (Id_Pegawai, Nama, Jenis_Kelamin, Id_Buku) values ('6666666662','Rizal','L','0000000002')")
                        + ("insert into Pegawai (Id_Pegawai, Nama, Jenis_Kelamin, Id_Buku) values ('6666666663','Muhammad','L','0000000003')")
                        + ("insert into Pegawai (Id_Pegawai, Nama, Jenis_Kelamin, Id_Buku) values ('6666666664','Ilham','P','0000000004')")
                        + ("insert into Pegawai (Id_Pegawai, Nama, Jenis_Kelamin, Id_Buku) values ('6666666665','Putri','P','0000000005')")
                        + ("insert into Struk (Id_Order, Jumlah_Barang, Jumlah_Harga, Tanggal, Id_Pegawai, Kode_Obat,Id_Pelanggan) values ('1111111111','20','Rp1000000','06-09-2022','6666666661','5555555551','2222222221')")
                        + ("insert into Struk (Id_Order, Jumlah_Barang, Jumlah_Harga, Tanggal, Id_Pegawai, Kode_Obat,Id_Pelanggan) values ('1111111112','25','Rp1000000','07-09-2022','6666666662','5555555552','2222222222')")
                        + ("insert into Struk (Id_Order, Jumlah_Barang, Jumlah_Harga, Tanggal, Id_Pegawai, Kode_Obat,Id_Pelanggan) values ('1111111113','10','Rp1000000','08-09-2022','6666666663','5555555553','2222222223')")
                        + ("insert into Struk (Id_Order, Jumlah_Barang, Jumlah_Harga, Tanggal, Id_Pegawai, Kode_Obat,Id_Pelanggan) values ('1111111114','30','Rp1000000','09-09-2022','6666666664','5555555554','2222222224')")
                        + ("insert into Struk (Id_Order, Jumlah_Barang, Jumlah_Harga, Tanggal, Id_Pegawai, Kode_Obat,Id_Pelanggan) values ('1111111115','15','Rp1000000','01-09-2022','6666666665','5555555555','2222222225')")
                        + ("insert into Buku (Id_Buku, Nama) values ('0000000001','Oktober')")
                        + ("insert into Buku (Id_Buku, Nama) values ('0000000002','Noveber')")
                        + ("insert into Buku (Id_Buku, Nama) values ('0000000003','Januari')")
                        + ("insert into Buku (Id_Buku, Nama) values ('0000000004','Februari')")
                        + ("insert into Buku (Id_Buku, Nama) values ('0000000005','Maret')")
                        + ("insert into Pelanggan (Id_Pelanggan, Nama, Kode_Transaksi) values ('2222222221','Bambang','3333333331')")
                        + ("insert into Pelanggan (Id_Pelanggan, Nama, Kode_Transaksi) values ('2222222222','Pamungkas','3333333332')")
                        + ("insert into Pelanggan (Id_Pelanggan, Nama, Kode_Transaksi) values ('2222222223','Ilham','3333333333')")
                        + ("insert into Pelanggan (Id_Pelanggan, Nama, Kode_Transaksi) values ('2222222224','Jaya','3333333334')")
                        + ("insert into Pelanggan (Id_Pelanggan, Nama, Kode_Transaksi) values ('2222222225','Isa','3333333335')")
                        + ("insert into Transaksi (Kode_Transaksi, Jenis_Transaksi, Tanggal) values ('3333333331','Debit','06-09-2022')")
                        + ("insert into Transaksi (Kode_Transaksi, Jenis_Transaksi, Tanggal) values ('3333333332','Kredit','07-09-2022')")
                        + ("insert into Transaksi (Kode_Transaksi, Jenis_Transaksi, Tanggal) values ('3333333333','Debit','08-09-2022')")
                        + ("insert into Transaksi (Kode_Transaksi, Jenis_Transaksi, Tanggal) values ('3333333334','Kredit','09-09-2022')")
                        + ("insert into Transaksi (Kode_Transaksi, Jenis_Transaksi, Tanggal) values ('3333333335','Debit','01-09-2022')"), con);

                cm.ExecuteNonQuery();

                Console.WriteLine("Sukses menambahkan data");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("gagal Menambahkan Data " + e);
                Console.ReadKey();
            }
            finally
            {
                con.Close();
            }
        }
        static void Main(String[] args)
        {
            new Program().InsertData();
        }
    }
}
