var builder = WebApplication.CreateBuilder(args);

// 이게 있어야 Controllers 작동
builder.Services.AddControllers();

var app = builder.Build();

// 이게 있어야 URL 연결됨
app.MapControllers();

app.Run();