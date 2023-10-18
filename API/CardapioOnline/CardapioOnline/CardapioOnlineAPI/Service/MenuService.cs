using CardapioOnlineAPI.Repositories;

namespace CardapioOnlineAPI.Service
{
    public class MenuService
    {
        private readonly MenuRepository _repository;

        public MenuService(MenuRepository repository)
        {
            _repository = repository;
        }

        public String GetAllMenuItems()
        {
            return _repository.GetAllMenuItems();
        }
    }
}
