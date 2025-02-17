﻿using ASDP.FinalProject.Constants;

namespace ASDP.FinalProject.DAL.Models
{
    public class Position
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public PositionCode Code { get; set; }
        public List<PositionPermission> Permissions { get; set; } = new List<PositionPermission>();

    }
}
