using Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Services
{
    public class ItemService : IItemService
    {
        private readonly IRepository<Item> _itemRepo;
        public ItemService(IRepository<Item> itemRepo)
        {
            _itemRepo = itemRepo;
        }

        public Item? GetItem(int id) 
        {
            return _itemRepo.GetById(id);
        }

        public IEnumerable<Item> GetAllItems()
        {
            return _itemRepo.GetAll();
        }

        public void Create(Item item)
        {
            _itemRepo.Create(item);
        }

        public void Update(Item item)
        {
            _itemRepo.Update(item);
        }

        public void Delete(Item item)
        {
            _itemRepo.Delete(item);
        }

        public bool Save()
        {
            return _itemRepo.Save();
        }
    }
}
