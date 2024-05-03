﻿using Education.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Education.Application.UseCases.VideoCases.Queries
{
    public class VideoById:IRequest<VideoModel>
    {
        public Guid Id { get; set; }
    }
}