using CategoryRepo.Exceptions;

namespace CategoryRepo
{
    public class Category
    {
        private int _productStock;

        public int Id { get; set; }
        public string Name { get; set; }

        public int ProductStock
        {
            get { return _productStock; }
            set {
                if (value == 0)
                {
                    new StockIsNullException();
                }

                _productStock = value;
            }
        }
    }
}
