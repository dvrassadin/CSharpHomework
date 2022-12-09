//
//  main.swift
//  Test
//
//  Created by Daniil Rassadin on 8/12/22.
//

import Foundation

var array = [3, 5, 1]

func sortToMax (array: inout [Int]) {
    for i in 0..<array.count - 1 {
        var position = i
        for j in i + 1..<array.count {
            if array[j] < array[position] {
                position = j
            }
            let temp = array[i]
            array[i] = array[position]
            array[position] = temp
        }
    }
}

sortToMax(array: &array)
print(array)
