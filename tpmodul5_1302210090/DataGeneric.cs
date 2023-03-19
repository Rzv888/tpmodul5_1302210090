namespace tpmodul5_1302210090
{
    internal class DataGeneric<T>{
        public T Data { get; set; }

        public DataGeneric(T data) {
            Data = data;
        }
        public void PrintData(){
            Console.WriteLine("Data yang tersimpan adalah: " + Data);

        }
    }
}
