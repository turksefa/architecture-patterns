using AutoMapper;
using Layered.BLL.Interfaces;
using Layered.BLL.Mapper;
using Layered.BLL.Services;
using Layered.DAL.Interfaces;
using Layered.DAL.Repositories;

var configuration = new MapperConfiguration(cfg => {
    cfg.AddProfile<MappingProfile>();
});
var mapper = new Mapper(configuration);

IUserRepository userRepository = new UserRepository();
IUserService userService = new UserService(userRepository, mapper);

foreach(var user in userService.GetAllUsers())
{
    System.Console.WriteLine($"{user.Email}");
}