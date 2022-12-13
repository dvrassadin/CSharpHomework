//
//  Service.swift
//  Task38_Swift
//
//  Created by Daniil Rassadin on 13/12/22.
//

import Foundation

/**
 Возвращает массив с count количеством элементов от minValue до maxValue с digits количеством цифр после точки.
 */
func createArrayWithDoubles(count: UInt, minValue: Double, maxValue: Double, digits: Double) -> [Double] {
    var array: [Double] = []
    guard count > 0 else { return array }
    for _ in 1...count {
        array.append(round(Double.random(in: minValue...maxValue) * pow(10, digits)) / pow(10, digits))
    }
    return array
}
/**
Возвращает разницу между максимальным и минимальными элементами массива или nil если массив пустой.
 */
func diffBetweenMaxAndMin(in array: [Double]) -> Double? {
    guard !array.isEmpty else { return nil }
    var max = array[0]
    var min = array[0]
    for i in 1..<array.count {
        if array[i] > max {
            max = array[i]
        }
        if array[i] < min {
            min = array[i]
        }
    }
    return max - min
}
