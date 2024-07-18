namespace EvSatinAlmak;

public abstract class Kisi
{
    protected ITransfer _transfer;

    protected Kisi(ITransfer transfer)
    {
        _transfer = transfer;
    }
}