namespace WebApplicationOne;

public class Startup
{
    public void Configure(IApplicationBuilder app)
    {
        app.UseOwin(buildFunc => buildFuncUseNancy());
    }

    public static void buildFuncUseNancy()
    {
        
    }
}