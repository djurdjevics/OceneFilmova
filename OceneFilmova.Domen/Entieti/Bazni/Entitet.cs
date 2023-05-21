namespace OceneFilmova.Domen.Entieti.Bazni
{
    public class Entitet<TId>
    {
        public TId ID { get; protected set; }

        public Entitet()
        {

        }

        public Entitet(TId id)
        {
            ID = id;
        }
    }
}
