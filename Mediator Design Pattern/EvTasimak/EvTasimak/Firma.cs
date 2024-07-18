namespace EvTasimak;

public abstract class Firma
{
    protected INakliye _nakliye;

    protected Firma(INakliye nakliye)
    {
        _nakliye = nakliye;
    }

    public abstract void NekliyeyeBasla();
}