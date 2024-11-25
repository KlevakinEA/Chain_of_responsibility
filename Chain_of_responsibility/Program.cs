Link a = new First(new Second());
Console.WriteLine(a.Action("A"));
Console.WriteLine(a.Action("B"));
try { Console.WriteLine(a.Action("C")); }
catch { Console.WriteLine("Error!"); }

a = new First(new Second(new Last()));
Console.WriteLine(a.Action("C"));




abstract class Link
{
    protected Link next;
    public Link(Link next) { this.next = next; }
    abstract public string Action(string action);
}


class First(Link next = null) : Link(next)
{
    override public string Action(string action) { if (action.Equals("A")) return "B"; else return next.Action(action); }
}


class Second(Link next = null) : Link(next)
{
    override public string Action(string action) { if (action.Equals("B")) return "C"; else return next.Action(action); }
}


class Last(Link next = null) : Link(next)
{
    override public string Action(string action) { return "Error"; }
}