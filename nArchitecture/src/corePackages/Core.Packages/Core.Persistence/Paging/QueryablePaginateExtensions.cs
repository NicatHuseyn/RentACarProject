using Microsoft.EntityFrameworkCore;

namespace Core.Persistence.Paging
{
    public static class QueryablePaginateExtensions
    {
        public static async Task<Paginate<T>> ToPaginateAsync<T>(
            this IQueryable<T> sources,
            int index,
            int size,
            CancellationToken cancellationToken = default
            )
        {
            int count = await sources.CountAsync( cancellationToken ).ConfigureAwait(false);
            List<T> items = await sources.Skip(index * size).Take(size).ToListAsync(cancellationToken).ConfigureAwait(false);

            Paginate<T> list = new()
            {
                Index = index,
                Count = count,
                Items = items,
                Size = size,
                PageCount = (int)Math.Ceiling(count/(double)size)
            };

            return list;
        }


        public static Paginate<T> ToPaginate<T>(
            this IQueryable<T> sources,
            int index,
            int size
            )
        {
            int count = sources.Count();
            List<T> items = sources.Skip(index * size).Take(size).ToList();

            Paginate<T> list = new()
            {
                Index = index,
                Count = count,
                Items = items,
                Size = size,
                PageCount = (int)Math.Ceiling(count / (double)size)
            };

            return list;
        }
    }
}
