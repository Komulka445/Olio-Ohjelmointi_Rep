using System.ComponentModel;
using System.Text;

public class Reppu
{
    //private lista[];
    public Tavara[] tavarat;
    public int maxtavarat;
    public double maxpaino;
    public double maxtilavuus;
    public int tavaroidenMaara;
    public double nykpaino;
    public double nyktilavuus;
    //konstru
    public Reppu(int maxtavarat, double maxpaino, double maxtilavuus)
    {
        this.maxtavarat = maxtavarat;
        this.maxpaino = maxpaino;
        this.maxtilavuus = maxtilavuus;
        tavarat = new Tavara[maxtavarat];
        tavaroidenMaara = 0;
        nykpaino = 0;
        nyktilavuus = 0;
    }

    public bool Lisää(Tavara tavara)
    {
        // täyys?
        if (tavaroidenMaara >= maxtavarat)
        {
            return false;
        }

        ///paijno
        if (nykpaino + tavara.Paino > maxpaino)
        {
            return false;
        }

        //tilva
        if (nyktilavuus + tavara.Tilavuus > maxtilavuus)
        {
            return false;
        }

        //////läpi
        tavarat[tavaroidenMaara] = tavara;
        tavaroidenMaara++;
        nykpaino += tavara.Paino;
        nyktilavuus += tavara.Tilavuus;
        return true;
    }

    //siölmukset
    public override string ToString()
    {
        if (tavaroidenMaara == 0)
        {
            return "Repussa ei ole tavaroita";
        }
        StringBuilder lista = new StringBuilder(); //bilderi
        lista.Append("Reppu sisältää seuraaavat tavarat: ");
        for (int i = 0; i < tavaroidenMaara; i++)
        {
            lista.Append(tavarat[i].ToString());
            if (i < tavaroidenMaara - 1)
            {
                lista.Append(", ");
                //listaa
            }
        }
        //nimi takas
        return lista.ToString();
    }
}
