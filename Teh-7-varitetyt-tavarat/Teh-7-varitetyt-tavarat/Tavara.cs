using System;
//vanha tavaraclässi
//pääklässi
public class Tavara
{
    public double Paino { get; }
    public double Tilavuus { get; }

    //konstruktori
    public Tavara(double paino, double tilavuus)
    {
        Paino = paino;
        Tilavuus = tilavuus;
    }

}

public class Nuoli : Tavara
{

    public Nuoli() : base(0.1, 0.05)
    {


    }
    public override string ToString()

    {
        return "Nuoli";
    }
}


public class Jousi : Tavara
{

    public Jousi() : base(1.0, 4.0)
    {
    }
    public override string ToString()
    {


        return "Jousi";
    }
}
public class Köysi : Tavara
{
    public Köysi() : base(1.0, 1.5)
    {
    }

    public override string ToString()
    {
        return "Köysi";
    }
}
public class Vesi : Tavara
{
    public Vesi() : base(2.0, 2.0)
    {
    }

    public override string ToString()
    {

        return "Vesi";

    }
}
public class Ruoka : Tavara
{
    public Ruoka() : base(1.0, 0.5)
    {
    }

    public override string ToString()
    {
        return "Ruoka";
    }
}
public class Miekka : Tavara
{
    public Miekka() : base(5.0, 3.0)
    {


    }

    public override string ToString()
    {
        return "Miekka";
    }
}

