# MVCCoreUsersWebAPIDemo
- Date- 31- May-2022
-To access data in react app (users) from web api(sql)

## ASP .Net Core Web API

- Database Connected
### After adding controller
1) run Visual studio code 
2) run get method in swagger
3) paste url of swagger(http://localhost:1907/api/Users) in home.js in react demo project
4) similarlly replace 3000 port url with above url in edit, add ,delete, details user 
5) refresh react app page (but data will not shown on page)
6) to show the data from sql add this line in startup file in visual studio
      -  app.UseCors(options => options.WithOrigins("http://localhost:3000").AllowAnyMethod().AllowAnyHeader());
7) now again run visual studio 
8) refresh react app page => data will be shown
