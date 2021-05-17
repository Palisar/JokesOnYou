﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using JokesOnYou.Web.Api.Data;
using JokesOnYou.Web.Api.DTOs;
using JokesOnYou.Web.Api.Models;
using JokesOnYou.Web.Api.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JokesOnYou.Web.Api.Repositories
{


    public class TagRepository : ITagRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TagRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateTagAsync(Tag tag)
        {
            try
            {
                await _context.Tags.AddAsync(tag).AsTask();
            }
            catch (Exception e)
            {
                Console.WriteLine("inner exception is: {0}", e.InnerException.Message);
            }
        }

        public async Task<IEnumerable<TagReplyDto>> GetAllTagDtosAsync()
        {
            return await _context.Tags.ProjectTo<TagReplyDto>(_mapper.ConfigurationProvider).ToListAsync();
        }
    }
}
