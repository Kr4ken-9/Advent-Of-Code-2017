pub fn captcha(input: &str) -> u32 {
    let mut output = 0;
    
    for i in 0..input.len() {
        let character = input.chars().nth(i).unwrap();

        if i == input.len() - 1 {
            if character == input.chars().nth(0).unwrap() {
                output += character.to_digit(10).unwrap();
            }
            break;
        }

        if character == input.chars().nth(i + 1).unwrap() {
            output += character.to_digit(10).unwrap();
        }
    }

    return output;
}

pub fn captcha_pt_two(input: &str) -> u32 {
    let mut output = 0;
    let offset = input.len() / 2;

    for i in 0..input.len() {
        let character = input.chars().nth(i).unwrap();
        let mut next_index = i + offset;

        if next_index >= input.len() {
            next_index = next_index - input.len()
        }

        if character == input.chars().nth(next_index).unwrap() {
            output += character.to_digit(10).unwrap();
        }
    }

    return output;
}