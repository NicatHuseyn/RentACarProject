﻿namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommandResponse
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public DateTime CreateDate { get; set; }
}
