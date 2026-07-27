class Solution:
    def hasDuplicate(self, nums: List[int]) -> bool:
        bag = []

        for n in nums:
            if n in bag:
                return True
            bag.append(n)
    
        return False
    