public class Main {
    public static void main(String[] args) {

        //Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
        //
        //You may assume that each input would have exactly one solution, and you may not use the same element twice.
        //
        //You can return the answer in any order.
        int[] nums = {2, 5};
        int target = 1;

        for (int i = 0; i < nums.length; i++) {
            for (int j = i + 1; j < nums.length; j++) {

                if (nums[i] + nums[j] == target) {
                    System.out.println("Indices: [" + i + ", " + j + "]");
                    return;

                }
                else {
                    System.out.println("Não encontrado");
                }
            }
        }
    } // Extremamente parecido com c# :P
}
