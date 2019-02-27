using CategoryRepo.Exceptions;

namespace CategoryRepo.Repositories
{
    public class Product
    {
        private Category _category;

        public int Id { get; set; }
        public string Name { get; set; }

        public Category Category
        {
            get { return _category; }
            set
            {
                if (value == null)
                {
                    new CategoryIsNullException();
                }

                _category = value;
            }
        }
    }
}