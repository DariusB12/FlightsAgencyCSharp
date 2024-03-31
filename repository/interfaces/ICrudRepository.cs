
using System;
using System.Collections.Generic;
using ProjectCS.model;

namespace ProjectCS.repository.interfaces
{
    public interface ICrudRepository<ID, E> where E : HasID<ID>
    {
        /// <summary>
        /// Finds an item
        /// </summary>
        /// <param name="id">The item id</param>
        /// <returns>The item if it exists, null otherwise</returns>
        /// 
        E findOne(ID id);

        /// <summary>
        /// Gets all the items
        /// </summary>
        /// <returns>An enumerable containing all the items</returns>
        IEnumerable<E> findAll();

        /// <summary>
        /// Saves an entity, in case of validation errors throws an exception
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <returns>The entity with the generated id if it was saved successfully
        ///             null otherwise
        /// </returns>
        E save(E entity);

        /// <summary>
        /// Deletes an entity
        /// </summary>
        /// <param name="id">The entity id</param>
        /// <returns>The removed entity</returns>
        void delete(ID id);

        /// <summary>
        ///  Updates an entity
        /// </summary>
        /// <param name="entity">The entity</param>
        /// <returns>The updated entity</returns>
        void update(E entity);

    }
}