using System;

class Hewan
{
    public string nama;
    public int umur;

    public Hewan(string nama, int umur)
    {
        this.nama = nama;
        this.umur = umur;
    }

    public virtual void Suara()
    {
        Console.WriteLine("Hewan ini bersuara");
    }

    public virtual void InfoHewan()
    {
        Console.WriteLine($"nama: {nama}");
        Console.WriteLine($"umur: {umur} tahun");
    }
}

class Mamalia : Hewan
{
    public int JumlahKaki;

    public Mamalia(string nama, int umur, int jumlahkaki) : base(nama,umur)
    {
        this.JumlahKaki = jumlahkaki;
    }

    public override void InfoHewan()
    {
        Console.WriteLine($"nama: {nama}");
        Console.WriteLine($"umur: {umur} tahun");
        Console.WriteLine($"jumlah kaki: {JumlahKaki}");
    }
}

class Reptil : Hewan
{
    public double PanjangTubuh;

    public Reptil(string nama, int umur, double panjangtubuh) : base(nama,umur)
    {
        this.PanjangTubuh = panjangtubuh;
    }

    public override void InfoHewan()
    {
        Console.WriteLine($"nama: {nama}");
        Console.WriteLine($"umur: {umur}  tahun");
        Console.WriteLine($"panjang tubuh: {PanjangTubuh} cm");
    }
}

class Singa : Mamalia
{
    public Singa(string nama, int umur, int jumlahkaki) : base(nama,umur,jumlahkaki)
    {

    }
    
    public override void Suara()
    {
        Console.WriteLine("Singa sedang mengaum");
    }

    public void Mengaum()
    {
        Console.WriteLine("Singa mengaum sangat keras di siang hari");
    }
}

class Gajah : Mamalia
{
    public Gajah(string nama, int umur, int jumlahkaki) : base(nama, umur, jumlahkaki)
    {

    }

    public override void Suara()
    {
        Console.WriteLine("Gajah sedang menderum");
    }
}

class Ular : Reptil
{
    public Ular(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh)
    {

    }

    public override void Suara()
    {
        Console.WriteLine("Ular sedang mendesis");
    }

    public void Merayap()
    {
        Console.WriteLine("Ular merayap dengan sangat cepat");
    }
}

class Buaya : Reptil
{
    public Buaya(string nama, int umur, double panjangtubuh) : base(nama, umur, panjangtubuh)
    {

    }

    public override void Suara()
    {
        Console.WriteLine("Buaya sedang menggeram");
    }
}

class KebunBinatang
{
    public List<Hewan> KoleksiHewan = new List<Hewan>();
    public void TambahHewan(Hewan hewan)
    {
        KoleksiHewan.Add(hewan);
    }

    public void DaftarHewan()
    {
        foreach (var hewan in KoleksiHewan)
        {
            hewan.InfoHewan();
            Console.WriteLine();
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        KebunBinatang kebunbinatang = new KebunBinatang();
        Singa singa = new Singa("Singa Jawa",10,4);
        Gajah gajah = new Gajah("Gajah Kalimamtan",5,4);
        Ular ular = new Ular("Ular Sumatera",8,15.7);
        Buaya buaya = new Buaya("Buaya Sulawesi",12,24.6);

        kebunbinatang.TambahHewan(singa);
        kebunbinatang.TambahHewan(gajah);
        kebunbinatang.TambahHewan(ular);
        kebunbinatang.TambahHewan(buaya);
        kebunbinatang.DaftarHewan();
        singa.Suara();
        gajah.Suara();
        ular.Suara();
        buaya.Suara();
        singa.Mengaum();
    }
}