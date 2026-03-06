using PH50619_03062026;
using System.Collections.Generic;
using System.Linq;

public class SanPhamService
{
    private List<SanPham> ds = new List<SanPham>();

    public SanPhamService()
    {
        ds.Add(new SanPham
        {
            ma = "001",
            ten = "SP1",
            gia = 10
        });
    }

    public int Count()
    {
        return ds.Count;
    }

    public bool Xoa(string ma)
    {
        var sp = ds.FirstOrDefault(x => x.ma == ma);

        if (sp == null)
            return false;

        ds.Remove(sp);

        return true;
    }

    public bool MaTonTai(string ma)
    {
        return ds.Any(x => x.ma == ma);
    }
}