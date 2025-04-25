using System;

interface IBuku
{
    string Info();
}

abstract class Buku : IBuku
{
    private string judul;
    private string penulis;
    private int tahun;

    public string Judul
    {
        get { return judul; }
        set { judul = value; }
    }

    public string Penulis
    {
        get { return penulis; }
        set { penulis = value; }
    }

    public int Tahun
    {
        get { return tahun; }
        set { tahun = value; }
    }

    public Buku(string judul, string penulis, int tahun)
    {
        this.judul = judul;
        this.penulis = penulis;
        this.tahun = tahun;
    }

    public abstract string Info();
}



class BukuFiksi : Buku
{
    public BukuFiksi(string judul, string penulis, int tahun) : base(judul, penulis, tahun) { }

    public override string Info()
    {
        return "[Fiksi] " + Judul + " oleh " + Penulis + " (" + Tahun + ")";
    }
}
class BukuNonfiksi : Buku
{
    public BukuNonfiksi(string judul, string penulis, int tahun) : base(judul, penulis, tahun) { }

    public override string Info()
    {
        return "[Non Fiksi] " + Judul + " oleh " + Penulis + " (" + Tahun + ")";
    }
}

class Majalah : Buku
{
    public Majalah ( string judul, string penulis, int tahun) : base(judul,penulis, tahun) { }
    public override string Info()
    {
        return " [Majalah] " + Judul + " oleh " + Penulis + " (" + Tahun + ")";
    }
}

class Perpustakaan
{
    private List<Buku> daftarBuku = new List<Buku>();
    private List<Buku> bukuDipinjam = new List<Buku>();

    public void Tambah(Buku buku)
    {
        daftarBuku.Add(buku);
    }

    public void LihatBuku()
    {
        Console.WriteLine("\nDaftar Buku:");
        for (int i = 0; i < daftarBuku.Count; i++)
        {
            Console.WriteLine((i + 1) + ". " + daftarBuku[i].Info());
        }
    }

    public void Pinjam(int index)
    {
        if (bukuDipinjam.Count >= 3)
        {
            Console.WriteLine("Maksimal 3 buku boleh dipinjam!");
        }
        else if (index >= 0 && index < daftarBuku.Count)
        {
            bukuDipinjam.Add(daftarBuku[index]);
            daftarBuku.RemoveAt(index);
            Console.WriteLine("Buku berhasil dipinjam.");
        }
    }
}

