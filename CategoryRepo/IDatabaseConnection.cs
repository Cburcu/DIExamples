namespace CategoryRepo
{
    public interface IDatabaseConnection
    {
        void ConnectDatabase();

        void DisConnectDatabase();
    }
}

