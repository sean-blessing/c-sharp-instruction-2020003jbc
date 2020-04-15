using System;

public class LineItem
{
    int quantity;
	public LineItem()
	{
	}

    public override string ToString() {
        return "Line Item:  quantity = "+quantity;
    }
}
