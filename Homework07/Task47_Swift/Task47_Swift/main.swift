//
//  main.swift
//  Task47_Swift
//
//  Created by Daniil Rassadin on 20/12/22.
//

// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

import Foundation

func createRealNumbersArray(rows: Int, columns: Int, minValue: Double, maxValue: Double) -> [[Double]]? {
    if rows < 1 || columns < 1 {
        return nil
    }
    
    var array: [[Double]] = [[]]
    
    for i in 0..<rows {
        array.append([Double]())
        for _ in 0..<columns {
            array[i].append(Double.random(in: minValue...maxValue))
        }
    }
    array.removeLast()
    return array
}

func printArray(_ array: [[Double]]) {
    for row in 0..<array.count {
        for element in array[row] {
            print(round(element * 100) / 100, terminator: " | ")
        }
        print("")
    }
}

var array = createRealNumbersArray(rows: 5, columns: 5, minValue: -10, maxValue: 10)

if let array {
    printArray(array)
} else {
    print("Такой масив нельзя создать")
}

