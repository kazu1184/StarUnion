/// <summary>
/// データの保管・遷移
/// </summary>
public class SharedData
{
    //シングルトン
    public static readonly SharedData instance = new SharedData();

    //クリアした時のタイム
    public int clear_time;
    //ステージの保管
    public int num_stage;
}
