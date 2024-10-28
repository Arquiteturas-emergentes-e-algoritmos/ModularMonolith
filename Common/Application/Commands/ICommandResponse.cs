﻿namespace Common.Application.Command;

public interface ICommandResponse
{
    public int Status { get; set; }
    public object? Data { get; set; }
    public string Message { get; set; }
}