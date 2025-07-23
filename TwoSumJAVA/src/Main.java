import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.stream.Collectors;

public class Main {

    public static void main(String[] args) {
        int[] nums = {3, 3};
        int target = 6;
        twoSum(nums, target);
    }

    public static int[] twoSum(int[] nums, int target) {

        List<Integer> integerList = Arrays.stream(nums).boxed().toList();

        ArrayList<Integer> result = new ArrayList<>();
        for (int i = 0; i < integerList.size(); i++) {
            int n = integerList.get(i);

            for (int j = 0; j < integerList.size(); j++) {
                int sn = integerList.get(j);

                int sum = n + sn;
                if (i != j && sum == target) {
                }
            }
        }
    }
}