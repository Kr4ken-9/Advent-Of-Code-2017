pub fn Captcha(input: &str) -> u32 {
    let mut first_int: u32 = 0;
    let mut last_int: u32 = 0;
    let mut output = 0;

    for (index, character) in input.chars().enumerate() {
        let int: u32 = character.to_digit(10).unwrap();
        
        if index == 0 {
            first_int = int;
            last_int = int;
            continue;
        }

        if index == input.len() - 1 {
            if int == first_int {
                output += int;
            }
        }

        if int == last_int {
            output += int;
        }

        last_int = int;
    }

    return output;
}

pub fn CaptchaPtTwo(input: &str) -> u32 {
    let mut output = 0;
    let offset = input.len() / 2;

    for (index, character) in input.chars().enumerate() {
        let mut next_index = index + offset;

        if next_index >= input.len() {
            next_index = next_index - input.len()
        }

        if character == input.chars().nth(next_index).unwrap() {
            output += character.to_digit(10).unwrap();
        }
    }

    return output;
}