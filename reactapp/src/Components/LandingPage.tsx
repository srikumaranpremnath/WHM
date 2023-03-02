import * as React from 'react';
import AppBar from '@mui/material/AppBar';
import Box from '@mui/material/Box';
import Button from '@mui/material/Button';
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardHeader from '@mui/material/CardHeader';
import CssBaseline from '@mui/material/CssBaseline';
import Grid from '@mui/material/Grid';
import StarIcon from '@mui/icons-material/StarBorder';
import Toolbar from '@mui/material/Toolbar';
import Typography from '@mui/material/Typography';
import Link from '@mui/material/Link';
import GlobalStyles from '@mui/material/GlobalStyles';
import Container from '@mui/material/Container';

function Copyright(props: any) {
  return (
    <Typography variant="body2" color="text.secondary" align="center" {...props}>
      {'Copyright © '}
      <Link color="inherit" href="https://mui.com/">
        Your Website
      </Link>{' '}
      {new Date().getFullYear()}
      {'.'}
    </Typography>
  );
}

const tiers = [
  {
    title: 'Units',
    subheader: 'Total no of units',
    price: '7',
    description: [
     'SriRhino growing day by day',
     'Currently with 7 units',
     'across the world'
    ],
    buttonText: 'View Units',
    buttonVariant: 'outlined',
  },
  {
    title: 'Stocks',
    subheader: 'Total no of Product in All units',
    price: '25000',
    description: [
      'Current stocked product count',
      'Is 25000'
    ],
    buttonText: 'View Stock',
    buttonVariant: 'contained',
  },
  {
    title: 'Categories',
    subheader: 'Total no of categories',

    price: '30',
    description: [
      '50 users included',
      '30 GB of storage',
      'Help center access',
      'Phone & email support',
    ],
    buttonText: 'View Catrgories',
    buttonVariant: 'outlined',
  },
];
const footers = [
  {
    title: 'Company',
    description: ['Team', 'History', 'Contact us', 'Locations'],
  },
  {
    title: 'Features',
    description: [
      'Cool stuff',
      'Random feature',
      'Team feature',
      'Developer stuff',
      'Another one',
    ],
  },
  {
    title: 'Resources',
    description: ['Resource', 'Resource name', 'Another resource', 'Final resource'],
  },
  {
    title: 'Legal',
    description: ['Privacy policy', 'Terms of use'],
  },
];

function Info() {
  return (
    <React.Fragment>
      <GlobalStyles styles={{ ul: { margin: 0, padding: 0, listStyle: 'none' } }} />
      <CssBaseline />
   
      <Container disableGutters maxWidth="lg" component="main" sx={{ pt: 8, pb: 6}}>
        <Typography
          component="h1"
          variant="h2"
          align="center"
          color="text.primary"
          gutterBottom
          style={{color:'white'}} 
        >
          Sri Rhino
        </Typography>
        <Typography  style={{color:'white'}}  variant="h5" align="center" color="text.secondary" component="p">
        As a WHM, Here we design, install and commission material handling, order fulfillment and distribution systems by combining equipment, controls 
        and software products into a turnkey solution. Our experts seek out leading technologies in both equipment and information systems coupled with proven 
        operational strategies. Our goal is to use these tools to help companies, across a broad spectrum of industry segments, 
        to be leaders in their industries. Whether you need a complete system solution or simply a single component integration, 
        we’ll put our expertise to work for you. We combine the best technologies for your project to create a personalized solution that exceeds expectations 
        so you can focus on achieving your operational and business goals.
        </Typography>
      </Container>
                    
      <Container maxWidth="md" component="main">
        <Grid container spacing={5}  alignItems="flex-end">
          {tiers.map((tier) => (
            <Grid
              item
              key={tier.title}
              xs={12}
              sm={12}
              md={4}
              style={{minHeight : 400}} 
            >
              <Card>
                <CardHeader
                  title={tier.title}
                  subheader={tier.subheader}
                  titleTypographyProps={{ align: 'center' }}
                  action={tier.title === 'Pro' ? <StarIcon /> : null}
                  subheaderTypographyProps={{
                    align: 'center',
                  }}
                  sx={{
                    backgroundColor: (theme) =>
                      theme.palette.mode === 'light'
                        ? theme.palette.grey[200]
                        : theme.palette.grey[700],
                  }}
                />
                <CardContent>
                  <Box
                    sx={{
                      display: 'flex',
                      justifyContent: 'center',
                      alignItems: 'baseline',
                      mb: 2,
                      
                    }}
                  >
                    <Typography component="h2" variant="h3" color="text.primary">
                      {tier.price}
                    </Typography>
                   
                  </Box>
                  <ul>
                    {tier.description.map((line) => (
                      <Typography
                        component="li"
                        variant="subtitle1"
                        align="center"
                        key={line}
                      >
                        {line}
                      </Typography>
                    ))}
                  </ul>
                </CardContent>
                <CardActions>
                  <Button
                    fullWidth
                    variant={tier.buttonVariant as 'outlined' | 'contained'}
                  >
                    {tier.buttonText}
                  </Button>
                </CardActions>
              </Card>
            </Grid>
          ))}
        </Grid>
      </Container>
      {/* Footer */}
      <Container
        maxWidth="md"
        component="footer"
        sx={{
          borderTop: (theme) => `1px solid ${theme.palette.divider}`,
          mt: 8,
          py: [3, 6],
        }}
      >
        <Grid container spacing={4} justifyContent="space-evenly">
          {footers.map((footer) => (
            <Grid item xs={6} sm={3} key={footer.title}>
              <Typography style={{color:'white'}} variant="h6" color="text.primary" gutterBottom>
                {footer.title}
              </Typography>
              <ul style={{color:'white'}}>
                {footer.description.map((item) => (
                  <li style={{color:'white'}} key={item}>
                    <Link href="#" variant="subtitle1">
                      {item}
                    </Link>
                  </li>
                ))}
              </ul>
            </Grid>
          ))}
        </Grid>
        <Copyright sx={{ mt: 5 }} />
      </Container>
      {/* End footer */}
    </React.Fragment>
  );
}

export default function Pricing() {
  return <Info />;
}