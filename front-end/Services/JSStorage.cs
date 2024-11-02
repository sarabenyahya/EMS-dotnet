using Microsoft.JSInterop;

namespace EMS.Services;

public class JSStorage(IJSRuntime js)
{
    private IJSRuntime Jsruntime { get; set; } = js;

    public IJSRuntime JSRuntime
    {
        get
        {
            return Jsruntime;
        }
    }

    public async Task Save(string key, string value)
    {
        await JSRuntime.InvokeVoidAsync("localStorage.setItem", key, value);
    }

    public async Task<string> Get(string key)
    {
        return await JSRuntime.InvokeAsync<string>("localStorage.getItem", key);
    }

    public async Task Remove(string key)
    {
        await JSRuntime.InvokeVoidAsync("localStorage.removeItem", key);
    }

}
