using tpmodul5_1302210090;

class program{
    static void Main(String[] args){


        HaloGeneric halo = new HaloGeneric();
        halo.SapaUser("Pesulap Merah");

        string NIM = "13021212132";

        DataGeneric<string> data = new DataGeneric<string>(NIM);

        data.PrintData();


    }

}