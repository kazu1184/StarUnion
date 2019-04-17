/// <summary>
/// ステージデータの保管・ロード
/// </summary>
public class Data
{
    //シングルトン
    public static readonly Data instance = new Data();

    //ステージの星の数
    public enum STAGE_ID
    {
        STAGE_1 = 0,
        STAGE_2,
        STAGE_3,
        STAGE_4,
        STAGE_5,
        STAGE_6,
        STAGE_7,
        STAGE_8,
        STAGE_9,
        MAX_STAGE
    }

    //メンバ変数
    static int[] num_star = new int[(int)STAGE_ID.MAX_STAGE];
    static int[][] num_data = new int[(int)STAGE_ID.MAX_STAGE][];
    static int[] num_trapezoid = new int[(int)STAGE_ID.MAX_STAGE];


    //ステージの星の数・データの追加
    public void LoadStageData(STAGE_ID num_stage,int star,int[] num)
    {
        num_star[(int)num_stage] = star;
        
        num_data[(int)num_stage] = new int[star];

        for (int i = 0; i < star; i++)
        {
            num_data[(int)num_stage][i] = num[i];
        }
    }

    //五角形の数字のデータ
    public void LoadTrapezoidData(STAGE_ID num_stage,int data)
    {
        num_trapezoid[(int)num_stage] = data;
    }

    //星の数を得る
    public int GetNumStar(STAGE_ID num_stage)
    {
        return num_star[(int)num_stage];
    }

    //星の数字を得る
    public int GetNum(STAGE_ID num_stage,int num)
    {
        //Debug.Log(num);
        //Debug.Log(num_data[(int)num_stage, num]);
        return num_data[(int)num_stage][num];
    }

    //五角形の数字を得る
    public int GetNum(STAGE_ID num_stage)
    {
        return num_trapezoid[(int)num_stage];
    }
}
