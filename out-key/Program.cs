// Từ khóa out
void func(out string outKeyVariable)
{
    outKeyVariable = "Init Out key"; // init giá trị tại đây
    outKeyVariable = outKeyVariable + " And use it";
}
string outKeyVariable; //không cần init
// Có thể không cần khởi tạo biến outKeyVariable mà dùng thẳng func(out string outKeyVariable) luôn
func(out outKeyVariable);
Console.WriteLine(outKeyVariable);

// Từ khóa ref
void func2(ref int refKeyVariable)
{
    refKeyVariable = refKeyVariable + 5;
}
int refKeyVariable = 5; //tạo biến và khởi tạo giá trị cho biến
func2(ref refKeyVariable);
Console.WriteLine(refKeyVariable);
Console.ReadLine();
