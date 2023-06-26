import { Box, Image } from "@chakra-ui/react";


export const Store = () => {
    const {id, name, image, description} = products;

  return (
    <Box maxW='sm' borderWidth='1px' borderRadius='lg' overflow='hidden'>
        <Image sec={image} alt={name} />

        <Box p='6'>
            <Box mt= '1' fontWeight='semibolld'/>
        </Box>

        <Box>
            {description}
        </Box>
    </Box>
  )
}
