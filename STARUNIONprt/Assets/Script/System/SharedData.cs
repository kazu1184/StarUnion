/// <summary>
/// データの保管・遷移
/// </summary>
public class SharedData
{
    //インスタンス化
    public static readonly SharedData instance = new SharedData();

    //クリアした時のタイム
    public int clear_time;
    public int num_stage;
}
