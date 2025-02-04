﻿using Microsoft.AspNetCore.Http; 
namespace Domain.Models;

public class Customer
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string Gender { get; set; }
    public string Address { get; set; }
}