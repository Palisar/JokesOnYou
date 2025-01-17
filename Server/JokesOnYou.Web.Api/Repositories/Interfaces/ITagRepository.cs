﻿using System.Collections.Generic;
using System.Threading.Tasks;
using JokesOnYou.Web.Api.DTOs;
using JokesOnYou.Web.Api.Models;

namespace JokesOnYou.Web.Api.Repositories.Interfaces
{
    public interface ITagRepository
    {
        void Delete(Tag tag);
        Task<Tag> GetTagAsync(int id);
        Task<List<Tag>> GetTags(int[] ids);
        Task<IEnumerable<TagReplyDto>> GetAllTagDtosAsync();
        Task<TagReplyDto> GetTagDtoAsync(int id);
        Task CreateTagAsync(Tag tag); 
    }
}
