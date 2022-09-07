﻿namespace Soccer_game_Common
{
    using System.Linq.Expressions;

    public interface IBaseUnitOfWork<T>
        where T : BaseEntity
    {
        Task<List<T>> ReadAsync();
        Task<T> ReadByIdAsync(Guid productId);
        Task<T> CreateAsync(T product);
        Task<T> UpdateAsync(T product);
        Task<T> DeleteAsync(Guid id);
    }
}