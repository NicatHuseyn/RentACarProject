using Core.Persistence.Paging;

namespace Core.Application.Responses;

public class GetListResponse<T>:BasePageableModel
{
    private IList<T> _items;

    public IList<T> Items 
    { 
        get => this._items?? new List<T>();
        set => this._items = value; 
    }
}
