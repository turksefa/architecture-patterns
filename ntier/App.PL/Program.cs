using App.BLL.Mapper;
using App.BLL.Services;
using App.DAL.Repositories;
using AutoMapper;

var configuration = new MapperConfiguration(cfg => {
    cfg.AddProfile<MappingProfile>();
});
var mapper = new Mapper(configuration);

UserRepository userRepository = new UserRepository();
UserService userService = new UserService(userRepository, mapper);

foreach(var user in userService.GetUsers())
{
    Console.WriteLine($"{user.Name}");
}